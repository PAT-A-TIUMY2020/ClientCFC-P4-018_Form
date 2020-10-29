using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_20180140018
{
    [ServiceContract]
    public interface IMatematika
    {
        [OperationContract]

        int Tambah(int a, int b); 
        [OperationContract]
        int Kurang(int a, int b);
        [OperationContract]
        int Kali(int a, int b);
        [OperationContract]
        int Bagi(int a, int b);
        [OperationContract]
        Koordinat TKoordinat(Koordinat a, Koordinat b); 

    }

    public class Koordinat
    {

    }


}
