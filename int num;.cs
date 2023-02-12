int num;
console.Write("3nter a number between 1'99");
num=int.Parse(console.ReadLine());
if ((num %7==10) || (num/10==7) || (num%10==7))
console.WriteLine("Boom!");