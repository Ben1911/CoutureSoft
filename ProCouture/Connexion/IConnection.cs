
using System;
using System.Data;

namespace ProCouture.Connexion
{
    internal interface IConnection
    {
        ConnexionType TypeConnexion { get; set; }
        IDbConnection Initialise();
    }
}
