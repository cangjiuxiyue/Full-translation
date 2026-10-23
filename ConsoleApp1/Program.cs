void ShowWelcome()
{
    Console.WriteLine("===翻译程序===");
}
void ShowInput(string text)
{
    Console.WriteLine($"你输入的英文是:{text}");
    Console.WriteLine($"字符数量{text.Length}");
}
ShowWelcome();
Console.Write("请输入一段英文,输入exit退出程序.");
Console.WriteLine();

while (true)
{
    Console.Write("请输入英文:");

    string? english = Console.ReadLine();

    if (english == null)
    {
        Console.WriteLine("输入结束,程序退出.");
        break;
    }

    if (english.Trim().ToLower() == "exit")
    {
        Console.WriteLine("再见!");
        break;
    }
    if
        (string.IsNullOrWhiteSpace(english))
    {
        Console.WriteLine("没有输入内容,请重新运行.");
    }
    else
    {
        ShowInput(english);
        //Console.WriteLine($"你输入的英文是:{english}");
        //Console.WriteLine($"字符数量:{english.Length}");
        Console.WriteLine("下一步,我们将为他接入真正的翻译功能.");
    }
    Console.WriteLine();

}
Console.WriteLine("程序结束,按任意键退出.");
Console.ReadKey();