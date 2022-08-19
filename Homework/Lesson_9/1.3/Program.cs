// 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.
int sumnums(int sum)

{
if(sum==0) return 0;
return sumnums (sum/10)+sum%10;

}

Console.WriteLine(sumnums( 123));

