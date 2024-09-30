namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modeloSmartphone, string imeiSmartphone, int memoriaSmartphone) : base(numero, modeloSmartphone, imeiSmartphone, memoriaSmartphone)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o app {nomeApp} no Nokia, aguarde uns instantes!");
        }
    }
}