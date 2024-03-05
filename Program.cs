string[] initial_array = {"dfghjkjhgfcx","g","tt","gglkkm"};

string[] SortOutAnArray(string[] user_input) {
    string final_str = string.Empty;
    for (int i = 0; i < user_input.Length; i++){
        if(user_input[i].Length < 4){
            final_str += user_input[i];
            final_str += " ";
        }
    }
    Console.Write(final_str);
    return final_str.Split(' ');
}


if (initial_array.Length == 1 && initial_array[0] == "-") {
    Console.WriteLine("Write down an array with , in between words");
    string user_input = Console.ReadLine();
    string[] to_be_modified = user_input.Split(',');
    SortOutAnArray(to_be_modified);
} else {
    SortOutAnArray(initial_array);
}