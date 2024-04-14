using static System.Console;
using static System.Convert;
using static System.Math;

int[] arr1 = new int[4];
int res = 0;


string str1 = ReadLine();
string str2 = ReadLine();
var arr2 = str1.Split(" ");
for(int i = 0; i< 4; i++)
{
    arr1[i] = ToInt32(arr2[i]);
}
for(int j = 0; j < str2.Length; j++)
{
    int x = str2[j]-'0';
    res += arr1[x - 1];
}


WriteLine(res);







