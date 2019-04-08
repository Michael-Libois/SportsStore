﻿using SportsStore.Domain.Entities;
using SportsStore.WebUI.Infrastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace SportsStore.WebUI.Infrastructure.Services
{
    public class RequestService : IRequestService
    {

        public void Send(Cart cart)
        {
            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Get;
                request.RequestUri = new Uri("https://localhost:44393/Payment/Create");
                var response = client.SendAsync(request);

                //rajouter la clé de l'API MVC qui envoie la requête et la référence du payment
                // dans le content de la requête?? Si oui, besoin d'un nouveau ViewModel??

                // Sans réponse pour le moment
                // .. ici il faut rajouter la récupération de l'api CORE (pas implémenté)

            }
        }



    }
}