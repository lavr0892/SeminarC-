
Console.Clear();
int[] array = {1, 7, 9, 0};
int max = array[0];
int max2 = array[1];

for (int i = 0; i < array.Length; i++)
  {
    if(array[0] > max)
    {
      max = array[0];
    }    
  }
if (max == array[0])
  {
    max2 = array[1];
  }
for(int i = 0; i < array.Length; i++)
  {
    if(array[0] == max)
      if(array[1] > max2)
        max2 = array[1];
  }




Console.WriteLine(max2);


