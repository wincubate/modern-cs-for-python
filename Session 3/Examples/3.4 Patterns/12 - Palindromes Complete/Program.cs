string s1 = "VoksneIrereDividererIEnSkov";
string s2 = "Otto";
string s3 = "NotAPalindrome";

Console.WriteLine(IsPalindrome(s1));
Console.WriteLine(IsPalindrome(s2));
Console.WriteLine(IsPalindrome(s3));

static bool IsPalindrome(string s) =>
    s switch
    {
        [] or [_] => true,
        [char a1, ..var middle, char a2] when char.ToLower(a1) == char.ToLower(a2) =>
            IsPalindrome(middle),
        _ => false
    };
