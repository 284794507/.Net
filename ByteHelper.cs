/// <summary>
/// ��ָ���ַ���ת����ASCII���ʾ���ض����ȵ��ַ����飬λ����������油0
/// </summary>
/// <param name="str"></param>
/// <param name="len"></param>
/// <returns></returns>
public static byte[] StrToASCII(string str, int len)
{
    System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();
    byte[] bAscii = ascii.GetBytes(str);
    int asciiLen = bAscii.Length;
    if (asciiLen == len)
    {
        return bAscii;
    }
    else
    {
        byte[] bApn = new byte[len];
        Buffer.BlockCopy(bAscii, 0, bApn, 0, asciiLen);
        if (asciiLen < len)
        {
            for (int i = asciiLen; i < len; i++)
            {
                bApn[i] = 0;
            }
        }
        return bApn;
    }            
}

/// <summary>
/// ��BCD��ת�����ַ���
/// </summary>
/// <param name="data"></param>
/// <param name="reverse"></param>
/// <returns></returns>
public static string ToStrFromBCD(byte[] data, bool reverse)
{
    string result = "";

    int len = data.Length;
    if(reverse)
    {
        for (int i = len-1; i >=0; i--)
        {
            result += data[i].ToString("X2");
        }
    }
    else
    {
        for (int i = 0; i < len; i++)
        {
            result += data[i].ToString("X2");
        }
    }

    return result;
}
        
/// <summary>
/// ��ʮ������ת����BCD���ʾ���ֽ�����
/// </summary>
/// <param name="val"></param>
/// <param name="len"></param>
/// <returns></returns>
public static byte[] ToBCDBytesFromUlong(ulong val,int len)
{
    byte[] result = new byte[len];
    int curIndex = 0;
    ulong curVal = val;
    while (true)
    {
        ulong remainder = 0;
        ulong quotient = 0;
        quotient = curVal / 100;
        remainder = curVal % 100;

        result[curIndex++] = Convert.ToByte(remainder.ToString(), 16);
        if (quotient == 0) break;
        curVal = quotient;
    }
    for(int i=curIndex;i<len;i++)
    {
        result[i] = 0;
    }
    
    return result;
}