using Americas.Api.Assertions;
using Americas.Api.Models;
using Americas.Api.Repository.Contracts;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Americas.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FapaccadController : ApiController
    {
        private HttpResponseMessage ResponseMessage;
        private readonly IFapaccadRepository _fapaccadRepository;

        public FapaccadController()
        {
            var context = new AmericasDbContext();
            _fapaccadRepository = context.GetFapaccadRepository();
            ResponseMessage = new HttpResponseMessage();
        }

        [HttpGet]
        [Route("api/fapaccads")]
        public Task<HttpResponseMessage> Get(int offset = 0, int length = 50)
        {
            var fapaccads = _fapaccadRepository.GetAll(offset, length);
            ResponseMessage = Request.CreateResponse(HttpStatusCode.Created, fapaccads);
            return Task.FromResult<HttpResponseMessage>(ResponseMessage);
        }

        [HttpGet]
        [Route("api/fapaccads/{cod_pac}")]
        public Task<HttpResponseMessage> Get(string cod_pac)
        {
            if (string.IsNullOrEmpty(cod_pac))
            {
                var error = new
                {
                    value = "O parâmetro cod_pac deve possuir um valor",
                    status = HttpStatusCode.InternalServerError
                };

                ResponseMessage = Request.CreateResponse(HttpStatusCode.BadRequest, error);
            }
            else
            {
                var itens = _fapaccadRepository.Find(cod_pac);
                if (itens == null)
                {
                    var error = new
                    {
                        value = "Paciente não encontrado",
                        status = HttpStatusCode.NotFound
                    };
                    ResponseMessage = Request.CreateResponse(HttpStatusCode.NotFound, error);
                }
                else
                {
                    ResponseMessage = Request.CreateResponse(HttpStatusCode.Created, itens);
                }
            }
            return Task.FromResult<HttpResponseMessage>(ResponseMessage);
        }

        [HttpPost]
        [Route("api/fapaccads")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            if (string.IsNullOrEmpty(body.ToString()))
            {
                var error = new
                {
                    value = "O parâmetro cod_pac deve possuir um valor",
                    status = HttpStatusCode.InternalServerError
                };

                ResponseMessage = Request.CreateResponse(HttpStatusCode.BadRequest, error);
            }
            else
            {
                Fapaccad fapaccad = new Fapaccad();//(((JValue)body.SelectToken("nome")).Value.ToString());
                                                   //fapaccad.DeserializeJson(body); //Converte Json para o objeto Apoiado
                fapaccad = JsonConvert.DeserializeObject<dynamic>(body);

                //Verifica se há inconsistência nos dados
                FapaccadAssertion fapaccadAssertion = new FapaccadAssertion(fapaccad, true);
                if (fapaccadAssertion.Notifications.HasNotifications())
                {
                    ResponseMessage = Request.CreateResponse(HttpStatusCode.InternalServerError, 
                        new { errors = fapaccadAssertion.Notifications.Notify() });
                }
                else
                {
                    _fapaccadRepository.Add(fapaccad);
                    //return CreatedAtRoute("GetApoio", new { id = apoiado.Id }, apoiado);
                    ResponseMessage = Request.CreateResponse(HttpStatusCode.Created, fapaccad);
                }
            }
            return Task.FromResult<HttpResponseMessage>(ResponseMessage);
        }

        [HttpPut]
        [Route("api/fapaccads/{cod_pac}")]
        public Task<HttpResponseMessage> Put(string cod_pac, [FromBody]dynamic body)
        {
            if (string.IsNullOrEmpty(body.ToString()))
            {
                var error = new
                {
                    value = "O parâmetro cod_pac deve possuir um valor",
                    status = HttpStatusCode.InternalServerError
                };

                ResponseMessage = Request.CreateResponse(HttpStatusCode.BadRequest, error);
            }
            else
            {
                //Verifica se o registro existe na base
                var fapaccadFounded = _fapaccadRepository.Find(cod_pac);
                if (fapaccadFounded == null)
                {
                    var error = new
                    {
                        value = "Paciente não encontrado",
                        status = HttpStatusCode.NotFound
                    };
                    ResponseMessage = Request.CreateResponse(HttpStatusCode.NotFound, error);
                }
                else
                {
                    Fapaccad fapaccadNew = new Fapaccad();
                    fapaccadNew = fapaccadFounded;
                    fapaccadNew = JsonConvert.DeserializeObject<dynamic>(body);
                    //fapaccadNew.DeserializeJson(body); //Converte Json para o objeto Apoiado

                    //Verifica se há inconsistência nos dados
                    FapaccadAssertion fapaccadAssertion = new FapaccadAssertion(fapaccadNew);
                    if (fapaccadAssertion.Notifications.HasNotifications())
                    {
                        ResponseMessage = Request.CreateResponse(HttpStatusCode.InternalServerError,
                            new { errors = fapaccadAssertion.Notifications.Notify() });
                    }
                    else
                    {
                        _fapaccadRepository.Update(fapaccadNew);
                        ResponseMessage = Request.CreateResponse(HttpStatusCode.OK, fapaccadNew);
                    }
                }
            }
            return Task.FromResult<HttpResponseMessage>(ResponseMessage);
        }

        [HttpDelete]
        [Route("api/fapaccads/{id}")]
        public Task<HttpResponseMessage> Delete(string cod_pac)
        {
            var fapaccad = _fapaccadRepository.Find(cod_pac);
            if (fapaccad == null)
            {
                var error = new
                {
                    value = "Paciente não encontrado",
                    status = HttpStatusCode.NotFound
                };
                ResponseMessage = Request.CreateResponse(HttpStatusCode.NotFound, error);
            }
            else
            {
                _fapaccadRepository.Remove(fapaccad);
                ResponseMessage = Request.CreateResponse(HttpStatusCode.OK, fapaccad);
            }
            return Task.FromResult<HttpResponseMessage>(ResponseMessage);
        }
    }
}