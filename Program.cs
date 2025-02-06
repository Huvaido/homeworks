// task1
// int a = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int [a];

// for(int i=0; i<arr.Length; i++){
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for(int i=0; i<arr.Length; i++){
//     if(i % 2 == 0){
//         System.Console.Write(arr[i] + " ");
//     }
// }

// task 2;

// int a = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int [a];
// for(int i=0; i<arr.Length; i++){
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for(int i=0; i<arr.Length; i++){
//     if(arr[i] % 2 == 0){
//         System.Console.Write(arr[i] + " ");
//     }
// }

//task 3;

// int a = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int [a];
// for(int i=0; i<arr.Length; i++){
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// int cnt = 0;
// for(int i=0; i<arr.Length; i++){
//     if(arr[i] > 0){
//         cnt++;
//     }
// }
// System.Console.WriteLine(cnt);

// task4;

// int a = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int[a];

// for(int i=0; i<arr.Length; i++){
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// int cnt = 0;
// for(int i=1; i<arr.Length; i++){
//     if(arr[i] > arr[i-1]){
//         cnt++;
//     }
// }
// System.Console.WriteLine(cnt);

// task5;
// int a = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int[a];

// for(int i=0; i<arr.Length; i++){
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// bool b = false;
// for(int i=1; i<arr.Length; i++){
//     if((arr[i] > 0  && arr[i-1] > 0) || (arr[i] < 0 && arr[i-1] < 0)){
//         b = true;
//     }
// }
// if(b == true){
//     System.Console.WriteLine("Yes");
// }
// else{
//     System.Console.WriteLine("No");
// }

// task 6;


// int a = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int[a];

// for(int i=0; i<arr.Length; i++){
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// int cnt = 0;
// for(int i=1; i<arr.Length; i++){
//     if(arr[i] < arr[i-1] && arr[i-1] > arr[i-2]){
//         cnt++;
//     }
// }
// System.Console.WriteLine(cnt);


// task7;

// int a = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int[a];

// for(int i=0; i<arr.Length; i++){
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for(int i=a-1; i>=0; i--){
//     System.Console.Write(arr[i] + " ");
// }

// task8;
//  int a = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int[a];

// for(int i=0; i<arr.Length; i++){
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < a - 1; i += 2)
// {
//     int temp = arr[i];
//     arr[i] = arr[i + 1];
//     arr[i + 1] = temp;
// }

// for (int i = 0; i < a; i++)
// {
//     Console.Write(arr[i] + " ");
// }

// task9;

// int a = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int[a];
// for(int i=0; i<arr.Length; i++){
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for(int i=a-1; i>0; i--){
//     (arr[i],arr[i-1]) = (arr[i-1],arr[i]);
// }
// for(int i=0; i<arr.Length; i++){
//     System.Console.Write(arr[i] + " ");
// }
// task10

// int a = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int[a];

// for(int i=0; i<arr.Length; i++){
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// int maxx = 0;
// for(int i=0; i<arr.Length; i++){
//     if(arr[i] > maxx){
//         maxx = arr[i];
//     }
// }
// System.Console.WriteLine(maxx);

// task 11;

// int a = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int[a];

// for(int i=0; i<arr.Length; i++){
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// int cnt = 1;
// for(int i=1; i<a; i++){
//     if(arr[i] != arr[i-1]){
//         cnt++;
//     }    
// }

// System.Console.WriteLine(cnt);

// task 12;
// int n = Convert.ToInt32(Console.ReadLine());
// string[] input = Console.ReadLine().Split();
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(input[i]);
// }
// int petyaHeight = Convert.ToInt32(Console.ReadLine());

// int cnt = 1;

// for (int i = 0; i < n; i++)
// {
//    if(petyaHeight < arr[i]){
//     cnt++;
//    }
// }
// Console.WriteLine(cnt);

// task 13;


