using System;

// Definindo a classe abstrata Smartphone
public abstract class Smartphone
{
    // Propriedade para armazenar o modelo do celular
    public string Modelo { get; set; }

    // Método abstrato que será sobrescrito nas classes filhas
    public abstract void InstalarAplicativo(string aplicativo);
}

// Classe Nokia que herda de Smartphone
public class Nokia : Smartphone
{
    // Implementação do método InstalarAplicativo específico para Nokia
    public override void InstalarAplicativo(string aplicativo)
    {
        Console.WriteLine($"Instalando {aplicativo} na plataforma Nokia.");
    }
}

// Classe iPhone que herda de Smartphone
public class iPhone : Smartphone
{
    // Implementação do método InstalarAplicativo específico para iPhone
    public override void InstalarAplicativo(string aplicativo)
    {
        Console.WriteLine($"Instalando {aplicativo} na plataforma iPhone.");
    }
}

// Classe principal que contém o programa
class Program
{
    static void Main()
    {
        // TODO: Crie instâncias dos celulares Nokia e iPhone e teste o método InstalarAplicativo
        Smartphone nokia = new Nokia();
        nokia.Modelo = "Nokia 3310";
        nokia.InstalarAplicativo("WhatsApp");

        Smartphone iphone = new iPhone();
        iphone.Modelo = "iPhone 12";
        iphone.InstalarAplicativo("Instagram");
    }
}
