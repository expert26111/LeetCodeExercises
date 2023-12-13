

//int[] array = { 3, 6, 9, 1 };
//Console.WriteLine(maximumgap(array));
//int[] array2 = { 100, 3, 2, 1 };
//Console.WriteLine(maximumgap(array2));

//int[] array3 = {15252,16764,27963,7817,26155,20757,3478,22602,20404,6739,16790,10588,16521,6644,20880,15632,27078,25463,20124,15728,30042,16604,17223,4388,23646,32683,23688,12439,30630,3895,7926,22101,32406,21540,31799,3768,26679,21799,23740};
//Console.WriteLine(maximumgap(array3));

using System;

int[] array4 = {494767408,862126209,213511142,768240025,631263193,839199222,990848796,214568815,540853864,760724418,980162605,976743981,168965760,680875496,256709197,970953816,948680062,347254784,732201399,786249847,782805044,40906641,674241381,784330934,175502610,731105392,424650824,549764101,986090032,710542549,249208107,448419816,527708664,158499246,223421723,114552457,466978424,821491411,19614107,115389497,902211438,2644108,744489871,897895073,372311214,551142753,933294894,426217662,217504874,983488406,516890023,426853110,971124103};
Console.WriteLine(maximumgap(array4));


int maximumgap(int[] nums)
{

    int numberofbuckets = nums.Length;
    if (numberofbuckets == 2)
    {
        return Math.Abs(nums[0] - nums[1]);
    }
    if (numberofbuckets == 1)
    {
        return 0;
    }
    // finding max and min 
    int max = int.MinValue;
    int min = int.MaxValue;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > max) max = nums[i];
        if (nums[i] < min) min = nums[i];
    }
    if (max == min) // all elements are equal
    {
        return 0;
    }

    // max amount in a bucket
    int amountInBucketMaxGap = (max - min) / numberofbuckets;
    int[][] bucket = new int[numberofbuckets+1][];
    for(int i = 0; i < bucket.Length; i ++)
    {
        bucket[i] = new int[2];
    }
    for (int i = 0; i < bucket.Length; i++)
    {
        bucket[i][0] = int.MaxValue; 
        bucket[i][1] = -1;
    }


    for (int i = 0; i < numberofbuckets; i++)
    {
        long number = (nums[i] - min);

        long number2 = number * numberofbuckets;

        double index1 = number2 / (double)(max - min);
        // adding to the each bucket , at position 0 - Min value, at position 1 - Max value
         
        int index = (int)index1;
        bucket[index][0] = Math.Min(bucket[index][0], nums[i]);
        bucket[index][1] = Math.Max(bucket[index][1], nums[i]);
    }

    // we need investigate only the edge of the buckets between max and next min
    // because only if all elements are equal then and only then the max difference 
    // is inside the buckets 
    // but we already return for all equal elements case


    // get first bucket max
    int previousMax = 0;
    if (bucket[0][1] != int.MaxValue)
    {
        previousMax = bucket[0][1];
    }
    

    for (int i = 1; i < numberofbuckets+1; i++)
    {
        if (bucket[i].Length == 0) continue;
        if (bucket[i][0] != int.MaxValue && bucket[i][1] != -1)
        {
                if (bucket[i][0]-previousMax > amountInBucketMaxGap)
                {
                    amountInBucketMaxGap = bucket[i][0] - previousMax;
                  
                }
            previousMax = bucket[i][1];
        }
        else
        {
            if(bucket[i][0] != int.MaxValue)
            {
                if (bucket[i][0] - previousMax > amountInBucketMaxGap)
                {
                    amountInBucketMaxGap = bucket[i][0] - previousMax;
                   
                }
                previousMax = bucket[i][0];
            }
            else if(bucket[i][1] != -1)
            {
                int number = bucket[i][1] - previousMax;
                if (number > amountInBucketMaxGap)
                {
                    amountInBucketMaxGap = bucket[i][1] - previousMax;
                    
                }
                previousMax = bucket[i][1];
            }
        }
    }
    return amountInBucketMaxGap;
}









// so investigate the edges 
//int firstmax = -1;
//int indx = 0;
//bool check = true;
//while (check)
//{
//    if (bucket[indx].count > 0)
//    {
//        firstmax = bucket[indx].max(x => x);
//        check = false;
//    }

//}

//int maxgap = 0;
//int minelement = 0;
//int maxelement = 0;

//for (int i = 0; i < bucket.length - 1; i++)
//{

//    if (bucket[indx].count > 0)
//    {
//        int firstmax = bucket[indx].max(x => x);
//        if (localmax > maxelement)
//        {
//            maxelement =
//        }
//        maxelement = bucket[indx].max(x => x);
//        minelement = bucket[indx].min(x => x);
//    }
//}




