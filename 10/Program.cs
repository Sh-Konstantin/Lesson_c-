string text = "Вот пока она здесь — еще всё хорошо:"
            + "подхожу и смотрю поминутно; а унесут завтра и — как же я останусь один?"
            + "Она теперь в зале на столе, составили два ломберных, а гроб будет завтра,"
            + "белый, белый гроденапль, а впрочем, не про то… ";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;     
    int length = text.Length;
    for (int i=0; i<length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";

    }

    return result;
}

string newText = Replace (text, ' ', '_');
Console.WriteLine(newText);