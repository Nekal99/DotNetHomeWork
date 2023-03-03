string x = Console.ReadLine();
int operatenum1 = int.Parse(x);
string y = Console.ReadLine();
int operatenum2 = int.Parse(y);
char operatorSymbol = (char)Console.Read();
switch (operatorSymbol)
{
    case '+':
    case '-':
    case '*':
    case '/':
        {
            switch (operatorSymbol)
            {
                case '+':
                    int resultplus = operatenum1 + operatenum2;
                    Console.WriteLine(operatenum1 + "+" + operatenum2 + "=" + resultplus);
                    break;
                case '-':
                    int resultminus = operatenum1 - operatenum2;
                    Console.WriteLine(operatenum1 + "-" + operatenum2 + "=" + resultminus);
                    break;
                case '*':
                    int resultmulti = operatenum1 * operatenum2;
                    Console.WriteLine(operatenum1 + "*" + operatenum2 + "=" + resultmulti);
                    break;
                case '/':
                    int resultdivision = operatenum1 / operatenum2;
                    Console.WriteLine(operatenum1 + "/" + operatenum2 + "=" + resultdivision);
                    break;
                default:
                    break;
            }

            break;
        }

    default:
        Console.WriteLine("没有相应的运算符");
        break;
}