using System;
using CartaoCreditoApi.Models;

namespace CartaoCreditoApi.RequestModels
{
    public class TransacaoRequestPost
    {
        public CartaoCreditoModel Cartao {get;set;}
        public decimal Valor {get;set;}
        public int QtdParcelas { get;set;}
    }
}