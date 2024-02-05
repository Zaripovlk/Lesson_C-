/* Задайте двумерный массив символов (тип char [,]). 
Создать строку из символов этого массива.*/
Console.Clear();
string CharStr(char[,] array)
{
    string result = "";
    int gor = array.GetLength(0);
    int vert = array.GetLength(1);

    for (int i = 0; i < gor; i++)
        for (int j = 0; j < vert; j++)
            result += array[i, j];
    return result;
}

char[,] charArray = {
        {'H', 'e' , 'l' , 'l', 'o', ' '},
        {'W', 'o', 'r', 'l', 'd', '!'}

};
string res = CharStr(charArray);
Console.WriteLine(res);
