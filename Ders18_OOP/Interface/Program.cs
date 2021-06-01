using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface -> Siniflarin icermesi gereken metotlarin ozelliklerinin yer aldigi taslak
            //Icerisindeki propertylere deger atamasi yapilmaz, metotlarin ici doldurulmaz
            //Bir sinif birden fazla interfaceden kalitilabilir

            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();

            SmsLogger smsLogger = new SmsLogger();
            smsLogger.WriteLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();
        }
    }
}
