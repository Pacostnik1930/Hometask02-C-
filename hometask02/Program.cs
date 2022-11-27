    
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if(numberText.Length > 2){
    Console.WriteLine(numberText[2]);
}
else{
    Console.WriteLine("третьей цифры нет");
}