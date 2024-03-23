using Common;
using Modbus.FunctionParameters;
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;

namespace Modbus.ModbusFunctions
{
    /// <summary>
    /// Class containing logic for parsing and packing modbus write coil functions/requests.
    /// </summary>
    public class WriteSingleCoilFunction : ModbusFunction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteSingleCoilFunction"/> class.
        /// </summary>
        /// <param name="commandParameters">The modbus command parameters.</param>
        public WriteSingleCoilFunction(ModbusCommandParameters commandParameters) : base(commandParameters)
        {
            CheckArguments(MethodBase.GetCurrentMethod(), typeof(ModbusWriteCommandParameters));
        }

        /// <inheritdoc />
        public override byte[] PackRequest()
        {
            //TO DO: IMPLEMENT
            // paket = napraviti niz od 12 byte
            // params = this.commandParameters cast read/write
            //short -> hton -> byte -> copy paket 

            //return paket
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override Dictionary<Tuple<PointType, ushort>, ushort> ParseResponse(byte[] response)
        {
            //TO DO: IMPLEMENT
            //recnik = napraviti recnik
            //adresu = response [8 i 9] -> short -> ntoh
            //vrednost = response [10 i 11] -> short -> ntoh
            //recnik.add(PT.DO,adresa,vrednost) AO za analogni
            //return recnik
            throw new NotImplementedException();
        }
    }
}