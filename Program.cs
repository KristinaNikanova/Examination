String[] array = {
    "jbl",
    "count",
    "fault",
    "size",
    "in",
    "out",
    "new",
    "camel",
    "length",
    "nails"
};

String[] filtered = filter(array);

foreach (String str in filtered)
{
    Console.WriteLine(str);
}

static String[] filter(String[] input)
{
    int[] indexes = new int[input.Length];
    int size = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
        {
            indexes[size] = i;
            size++;
        }
    }

    String[] output = new String[size];
    for (int i = 0; i < size; i++)
    {
        output[i] = input[indexes[i]];
    }

    return output;
}
