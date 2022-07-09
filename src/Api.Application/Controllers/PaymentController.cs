using System.Threading.Tasks;
using Api.Domain.Interfaces.Services.Payment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Stripe;
using Stripe.Checkout;
using System.Collections.Generic;


namespace Api.Application.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class PaymentController
    {
        //private IPaymentService _paymentService;
        public PaymentController(/*IPaymentService paymentService*/)
        {
            //_paymentService = paymentService;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<object> Payment()
        {
            var options = new SessionCreateOptions
            {
                LineItems = new List<SessionLineItemOptions>
                {
                  new SessionLineItemOptions
                  {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                      UnitAmount = 2000,
                      Currency = "usd",

                      ProductData = new SessionLineItemPriceDataProductDataOptions
                      {
                        Name = "T-shirt",
                      },

                    },
                    Quantity = 1,
                  },
                },
                Mode = "payment",
                SuccessUrl = "http://localhost:4242/success.html",
                CancelUrl = "http://localhost:4242/cancel.html",
            };
            var service = new SessionService();
            Session session = service.Create(options);

            return new StatusCodeResult(303);
        }
    }
}
