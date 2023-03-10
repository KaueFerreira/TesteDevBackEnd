using System;
using System.Collections.Generic;

namespace TesteDevBackEnd.Domain
{
    public class CreditoBuilder
    {
        public Credito Build(TipoCredito tipoCredito)
        {
            Func<Credito> buildAction;

            if (itemBuilders.TryGetValue(tipoCredito, out buildAction))
            {
                return buildAction();
            }

            return null;
        }

        public CreditoBuilder RegisterBuilder(TipoCredito tipoCredito, Func<Credito> buildAction)
        {
            itemBuilders.Add(tipoCredito, buildAction);
            return this;
        }

        private Dictionary<TipoCredito, Func<Credito>> itemBuilders = new Dictionary<TipoCredito, Func<Credito>>();
    }
}
