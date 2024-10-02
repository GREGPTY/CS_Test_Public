using iTextSharp.text.pdf;
using Pruebas.packages;
using Pruebas.exceptiones;
using System.Reflection;
using Pruebas.convertTo;
using System.Text;
//Hola

// See https://aka.ms/new-console-template for more information

/*System.Random random = new System.Random();
System.Console.WriteLine(random.Next(34));
Type type = typeof(Random);
System.Console.WriteLine(type.Namespace);

Byte[] b = new Byte[1];
Random r = new Random();

r.NextBytes(b);
foreach (byte byteValue in b)
    Console.WriteLine("El numero generado es: " + byteValue);
*/
// Load the iTextSharp assembly
/*string namespaceName = "iTextSharp";
Assembly assembly = Assembly.Load("itextsharp");

foreach (Type type in assembly.GetTypes())
{
    if (type.Namespace != null && type.Namespace.StartsWith(namespaceName))
    {
        if (type.FullName.StartsWith("iTextSharp.text.pdf"))
        {
            Console.WriteLine(type.FullName);
        }
    }
}*/
/*
PdfModule pdfPodule = new PdfModule();
ConvertTo convertTo = new ConvertTo();
pdfPodule.saludo();
string pdfRuteInput = @"D:\Documents\Aurora\";
string pdfFileInput = "Medicina Interna Harrison 21º Edición Tomo II";
string pdfFullInputPath = Path.Combine(pdfRuteInput,pdfFileInput+".pdf");
string pdfRuteOutput = @"D:\Documents\Aurora\CapSacados\";
string pdfFileOutput = "Neumologia(Tomo2_Resumido).pdf";
Console.WriteLine("Ruta de salida: " +pdfRuteOutput);
string c = "(1)";
Console.WriteLine("Es un Numero?\n Answer: " + convertTo.isInteger(c));
Console.WriteLine("El numero que le sigue a " + c + ", es:" + convertTo.countIntegerWithParenthesis(c));
pdfPodule.extractPagesFromOtherPdf(pdfFullInputPath, pdfRuteOutput, pdfFileOutput);*/


/*Console.WriteLine(convertTo.convertInverseString(")Hola("));
Console.WriteLine(convertTo.convertInverseStringWithPharentesis("(Hola)"));

Console.WriteLine("La ruta anterior es: ["+pdfRuteOutput+ pdfFileOutput + "].");
string ruta =convertTo.convertReplaceNamePdf(pdfRuteOutput, pdfFileOutput);
Console.WriteLine("La ruta nueva es: ["+ruta+"].");
c = ")3(";
Console.WriteLine("\n\n\n");
ruta = convertTo.convertInverseString(c);//primero debemos invertir los datos actuales porque tenemos )1( y debe ser puesto a (1)
Console.WriteLine("1. "+ruta);                                     //
ruta = convertTo.countIntegerWithParenthesis(ruta);//y luego aumentamos el numero dentro de '(',')'
Console.WriteLine("2. "+ruta);


//Console.WriteLine("Este caracter es un numero?\nAnswer:"+convertTo.isIntegerOneToOne(number));
char number = '7';
Console.WriteLine("Es entero completo?: "+convertTo.isIntegerOneToOne(number));*/
//string hello = Console.ReadLine();
//int b = Convert.ToInt32(number);
//List<char> listchar = new List<char> {'a','b','c','d','e' };
/*do { 
    Console.WriteLine("Primero en la cola: "+listchar[0]);
    listchar.RemoveAt(0); 
} while (listchar.Count>0);//*/

//Console.WriteLine(pdfPodule.extractTextFromPdf());*/

//Module 2 Modulo 2
Console.WriteLine("Hello World");
string word = null;
word = "Hola " +
        "Hola 2";
Console.WriteLine("La variable word tiene la palabra [" + word +"] y esta tiene un tamaño de "+word.Length);

//Console.WriteLine(word[1:2]);//no funciona

//en python se puede imprimir la respuesta multiples veces solo añadiendo *, ej 'a'*3 = aaa, aqui no funciona 
char caracter = 'a';
Console.WriteLine("tenemos la letra a y su codigo ascii es: "+((int)caracter));
//python: alphabet = "abcdefghijklmnopqrstuvwxyz"
//print("f" in alphabet)
string alphabet = "abcdefghijklmnopqrstuvwxyz";
//Console.WriteLine(alphabet.Contains("d"));//.contains() es la contraparte en c#
alphabet.Insert(5,"Hola");
Console.WriteLine(alphabet);
//Console.WriteLine("New String: "+alphabet.Insert(2," HELLO "));
Console.WriteLine("Index of \"f\" in string is: "+alphabet.IndexOf("f"));

/*Console.Write("Introduce un carácter: ");
char caracter = Console.ReadKey().KeyChar;
int codigoAscii = (int)caracter;

Console.WriteLine($"\nEl código ASCII de '{caracter}' es {codigoAscii}");*/
