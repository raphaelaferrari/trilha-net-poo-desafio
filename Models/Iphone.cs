namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modeloSmartphone, string imeiSmartphone, int memoriaSmartphone) : base(numero, modeloSmartphone, imeiSmartphone, memoriaSmartphone)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o app {nomeApp} no Iphone, aguarde uns instantes!");
        }
    }
}