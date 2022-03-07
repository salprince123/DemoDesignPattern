using System;
namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTrack staticTrack = new MyTrack();
            Console.Write("TRAIN :");
            MyTrain train = new MyTrain();            
            staticTrack.Active(train);
            //sau do nguoi ta them xe bus 
            MyCar car = new MyCar();
            //nguoi ta muon xe bus chay tren duong ray 
            //staticTrack.Active(bus);
            //khoong khop nen khong xai duoc
            //=> khong thay doi duoc track va train ==> cai them adapter
            Console.Write("CAR :");
            MyTrainAdapter adapter= new MyTrainAdapter(car);
            staticTrack.Active(adapter);
        }
    }

    internal class MyTrainAdapter : MyTrain
    {
        private MyCar _car;
        public MyTrainAdapter(MyCar car)
        {
            _car = car;
        }
    }

    internal class MyCar
    {
        public MyCar()
        {
        }
    }

    internal class MyTrain
    {
        public MyTrain()
        {
        }
    }

    internal class MyTrack
    {        
        public void Active(MyTrain train)
        {
            Console.WriteLine("This vehicle can run on a track !");
        }
    }

}
