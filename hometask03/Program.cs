//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

int number = int.Parse(Console.ReadLine());

if(number == 1){
    Console.WriteLine("понедельник,рабочий день");
}
if(number == 2){
    Console.WriteLine("вторник,рабочий день");
}
if(number == 3){
    Console.WriteLine("среда,рабочий день");
}
if(number == 4){
    Console.WriteLine("четверг,рабочий день");
}
if(number == 5){
    Console.WriteLine("пятница,рабочий день");
}
if(number == 6){
    Console.WriteLine("Урааа!!Сегодня суббота,выходной");
}
if(number == 7){
    Console.WriteLine("Урааа!!Сегодня воскресенье,выходной");
}