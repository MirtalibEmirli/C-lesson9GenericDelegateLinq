// 
using C_lesson9Generic.Extensionmethoods;
using C_lesson9Generic.Models;
using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Xml.XPath;


ProgramDocumentcs a = new ProgramDocumentcs();



/*
 Task:

 1. DocumentProgram adinda bir class yaradin hansi ki icinde uc metod var:

	- OpenDocument 
	- EditDocument (virtual)
	- SaveDocument (virtual)

	Her uc metod voiddir ve ekrana acagidakilari cixardirlar.
	
	1. Document Opened
	2. Can Edit in Pro and Expert versions
	3. Can Save in Pro and Expert versions

 2. ProDocumentProgram adinda bir class yaradin hansi ki DocumentProgram classindan miras alir ve ekrana asagidakilari cixardir:
	
	1. Document Opened
	2. Document Edited (burda override elediyiniz metodu seald edirsiniz)
	3. Document Saved in doc format, for pdf format buy Expert packet

3. ExpertDocument adinda bir class yaradin hansi ki ProDocumentProgram classindan miras alir ve ekrana asagidakilari cixardir:

	1. Document Opened
	2. Document Edited
	3. Document Saved in pdf format

4. Program ise duse zaman userden acar daxil etmeyini isteyirsiniz. Acarlar basic, pro ve expert sozleridir. Qebul elediyiniz acara uygun olaraq muvafiq obyektleri yaradirsiniz:
	
	basic = DocumentProgram
	pro = ProDocumentProgram 
	expert = ExpertDocument 

ve OpenDocument, EditDocument, SaveDocument metodlarini cagirirsiniz;

Qeyd: Qebul olunan acara gore yaradilan obyektler DocumentProgram classina upcast olunmalidir. Meselen asagidaki kimi

	DocumentProgram docProgram = new ProDocumentProgram(); ve ya 
	DocumentProgram docProgram = new ExpertDocument ();


Ugurlar...
*/
while (true)
{

    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine("Welcome ");
    Console.ForegroundColor = ConsoleColor.White;


    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(@"
[1] => basic
[2] =>pro
[3] =>expert
[0] =>exit
");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Enter your Choice => ");

    int s = Convert.ToInt32(Console.ReadLine());


    switch (s)
    {
        case 1:

            DocumentProgram docProgram1 = new DocumentProgram("Doc", "basic", "Miri", DateTime.Now, "DocProgram");
            docProgram1.Show();
            docProgram1.OpenDocument();
            docProgram1.EditDocument();
            docProgram1.SaveDocument();
            docProgram1.Dispose();
            Thread.Sleep(2500);

            break;

        case 2:
            DocumentProgram docProgram2 = new ProgramDocumentcs("Doc", "basic", "Miri", DateTime.Now, "DocProgram");
            docProgram2.Show();
            docProgram2.OpenDocument();
            docProgram2.EditDocument();
            docProgram2.SaveDocument();
            docProgram2.Dispose();
            Thread.Sleep(2500);
            break;

        case 3:
            DocumentProgram docProgram3 = new ExpertDocument("Doc", "basic", "Miri", DateTime.Now, "DocProgram");
            docProgram3.Show();
            docProgram3.OpenDocument();
            docProgram3.EditDocument();
            docProgram3.SaveDocument();
            docProgram3.Dispose();
            Thread.Sleep(2500);

            break;

        case 0:
            Console.WriteLine("BYe");
            Thread.Sleep(2500);

            return;

        default:
            break;
    }


}







































#region Notes

//-------------------------------
//Etnesion methods
//Etnesion  methodlari var olan  bir classa elave edmek isdedikde isdifade edirik
//meselen bir methodu string uzun cox isdifade edirikse onu Extension method ede bilerik
//bu methodar static klsssin daxilinde static method olduqlari ucun
//obyek uzerinden onun oz funksiyaari kimi catmaq olur  
/*string mys = @"
S
M
A
R
T

";
Console.WriteLine(mys.Countlines()); //burdaki Countlines bize extension method olaraq gelir ve lineleri sayir stringdeki

//hemde enum kmi bir type ye funksionalliq elave demeye imkan verir

Console.WriteLine(Season.Spring.Next());



//-------------------------------------------------------------------
public enum Season
{
    Winter,
    Spring,
    Summer,
    Autmn
}
///////
/////////string ?a = null;
/////////string b=a  ??" " ;
///////
/////////Console.WriteLine(b);
*/

//*********
//DElegates


/*
Myd obj1 = F;
Myd2 obj2 = new Myd2( Doo); //way to initalize
*//*obj2.Invoke();
//yada
obj2();*/


/*
//bir delegatda bir nece function saxlamaq olar
obj2 += Foo;
//ve biz obj ni cagirib isledende funksiyalar ardicil isleyr

//obj2.GetInvocationList()[0].DynamicInvoke();
//bu formada ise biz hansi funksyani isteyrikse onu islederk




#pragma warning disable CS8601 // Possible null reference assignment.

//obj2 -= Doo; // burda ise bir funsiyani delegatdan cxarmaq ollur

#pragma warning restore CS8601 // Possible null reference assignment.



Myd3 obj4 = new Myd3(Sum); //parametrli funksiya saxlamaq
//obj4.Invoke(4,4); funksya parametrlidirse o zaman invoke edende parametr verilir
Action obj5 = F; // adi action void return typeli saxlyr
Action<int, double> obj6 = Sum2;//generic versiyasi


*/
//--------------------funktor return typeli
//Func<> obj8 = F; //void saxlamaq olmazz
/*Func<int> obj9 = Doo;
*//*obj9();*//*



Func<int, int> obj10 = Sum3;
Console.WriteLine(obj10.Invoke(3));*/
/*
Func<string, int> ab = new Func<string,int>(StoFloat);

Console.WriteLine(ab.Invoke("4g"));
*/

//--------PRedikatlar bool return typeli bir parametrli funksyalar saxlayr
/*
Predicate<int> obj9 = ISa; 



//Birlist e liste oz funksyamizi gondermek
List<int> list = new List<int>() { -2,23,34321,-1234,12343};

Action<int> action = Wr;
list.ForEach(Wr);
Console.WriteLine();
Func<int, bool> compr = isneg;
Console.WriteLine(list.All(compr));    //bii bele menfidise false alqortmi ozun qura bisen



*/

//Anonim Function


//Way 1 delegate oile yaradlr

//List<int> a = new List<int>() { 3,4,23,32,323,-3,-8};
/*Console.WriteLine(
a.All(
    delegate (int num){
    return num > 0 ? true : false;  }  //anonim function
)
);*/

//a.ForEach( num => Console.WriteLine(num)); // lambda nin en asan yazls formasi 
//bir parametr ve bir setr yazacuqsa () ve {} ehtiac olmur




//way 2 Lamda
/*
 () => parametrler qeyd olnr
{} -  body yazlr 
=> funksya oldgn bildirir ,lambda expression
 
 */
//ints.ForEach(
//    (int num) => { Console.WriteLine(num); }
//    );


//ints.All(
//    (int num) => { return num > 0 ? true : false; }
//);


//ints.ForEach(
//    ( num) => { Console.WriteLine(num); }
//);


//// Eyer parametrlerin sayi sadece 1-dirse o zaman yumru Moterezeler qeyd edilmeye biler.
//ints.ForEach(
//   num => 
//   { 
//       Console.WriteLine(num); 
//   }
//);


//// Eyer funksiya body-si sadece 1 expression-dirse o zaman Scope acmaqa ehtiyac yoxdur.
//ints.ForEach(num => Console.WriteLine(num) );

//Func<int, double, double> func =  (int num_1, double num_2) =>
//{
//    if (num_1 > 0)
//    {
//        return num_1 + num_2;
//    }
//    else
//    {
//        return num_1 - num_2;
//    }
//};




// Qeyd: Herhansisa  bit type-a  yeni class-a  sonradan yazilmish elave edilmish methodlar
// Extention Method Yaza bilmek ucun Bizim Static Bir Class-a ehtiyacimiz var
// ve extenntion methodlar mutle shekilde ozleride static olmalidirlar

/*
//---------------------------
bool isneg(int num)
{
    if (num > 0) { return true; }
    else
        return false;
}


void Wr(int num){
    Console.WriteLine(num);
}
bool ISa(int a)
{
    Console.WriteLine(a);
    
    return true;
}

int StoFloat(string a)
{
    Console.WriteLine("A");
    try
    {
        int tt = (Convert.ToInt32(a));
        return tt;

    }
    catch (Exception ex) {
        Console.WriteLine(ex.Message);
    }
    return 1;
}


*/

#region Funks
int Sum3 (int num2)
{
    return num2 + 2;
}


void Sum2(int num_1, double num_2)
{

}
void F()
{
    Console.WriteLine("AAA");
}
int Doo()
{
    Console.WriteLine("Saaaaaaaaaaalam");
    return 1;
}

int Foo()
{
    Console.WriteLine("Saaaaaaaaaaalam men Foo" );
    return 1;
}

void Sum(int a , int b)
{
    Console.WriteLine("Sum " + (a + b));

}
delegate void Myd(); //void return type li function saxlaya bilr
delegate int Myd2();
delegate void Myd3(int a, int b);//parametrli funksiya saxlamaq
                                 //bu delegateler de biz ne saxlayaciqsa onu rahatlqla bildirrik






#endregion
/*


Dictionary<string, int> a = new Dictionary<string, int>();

// Örnek değerler ekleme
a.Add("anahtar1", 1);
a.Add("anahtar2", 2);
a.Add("anahtar3", 3);

// Tüm anahtar-değer çiftlerine erişim
foreach (var pair in a)
{
    Console.WriteLine($"Anahtar: {pair.Key}, Değer: {pair.Value}");
}
decimal d = 10m;*/










#region IDispos

/*
using Ds d = new Ds();


class Ds :IDisposable
{
    public int a = 9;
  public  Ds()
    {
        Console.WriteLine("Ds constructor \n");
    }

    public void Dispose()
    {


        a = 0;
        Console.WriteLine("end " + a);
    }
}
*/
#endregion
#region IEquatablew 

/*
class A : IEquatable<int>// burdaki generic bize hansi type ile muqayise edeceymzi deyir
                         , IComparable //<object> generic de ede bilerik edmeyede
    ,IConvertible //type convert edir

{ 
   public int _x = 8;

    

    public TypeCode GetTypeCode()
    {
        throw new NotImplementedException();
    }

    public bool ToBoolean(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public byte ToByte(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public char ToChar(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public DateTime ToDateTime(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public decimal ToDecimal(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public double ToDouble(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public short ToInt16(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public int ToInt32(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public long ToInt64(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public sbyte ToSByte(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public float ToSingle(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public string ToString(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public object ToType(Type conversionType, IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public ushort ToUInt16(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public uint ToUInt32(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public ulong ToUInt64(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }




    public int CompareTo(object? obj) //generic olmayan versiya butun typeler isleye bilir
    {
        throw new NotImplementedException();
    }

    public bool Equals(int other)
    {


        throw new NotImplementedException();
    }
}



*/

#endregion






/*
 * 
 * 
A b = new A();
B a =b.Get<B>();

a.Foo();
class A
{
    public T Get<T>() where T : class, new()
    {
        T b = new T();
    return b;
    }
}

class B
{
    public void Foo()
    {
        Console.Write("B");
    }

}*/



/*
A b = new A();
b.Get<B>();

class A
{
    public *//*void*//* int Get<T>() //*where T : class, new()*//*
    {
        Console.WriteLine("Generic with void ");
        return 1; //bu ozaman olurki adi typedir
        //biz genericden gelen type ni return da vermek isdeyrikse o zaman filter isledmelyk
        //T a = new T(); 
        //eyer biz -> where T : class, new() bu keywordu isdifade edmemisikse funksiya daxilinde
        //T typnda deysen yaratmaq olmaz cunki bildirmemisik ki o reference typedir
    }
}

class B
{
    public void Foo()
    {
        Console.Write("B");
    }

}
*/



#endregion