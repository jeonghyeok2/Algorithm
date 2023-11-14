string input = Console.ReadLine();
//크로아티아 알파벳 저장
string[] alpabet = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
//크로아티아 알파벳 크기만큼 반복
for (int i = 0; i < alpabet.Length; i++) 
{   //input의 값을 RePlace로 변경해서 다시 input값으로 저장
    input = input.Replace(alpabet[i], "_");
}
//입력받은 값에는 크로아티아의 알파벳이 섞이고 크기고 달라 크기가 1인 문자로 변경 후 크기 출력
Console.WriteLine(input.Length);   