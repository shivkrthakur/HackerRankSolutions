/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string str = Console.ReadLine();
        char[] output = str.ToCharArray();
        
        for(int i = 0, j = n - 1; k >= -1 && i < j; i++, j--){
            if(str[i] > str[j]){
                output[j] = output[i];
                k--;
            }
            else if(str[i] < str[j]) {
                output[i] = output[j];
                k--;
            }
        }

        if(k < 0){
            Console.WriteLine(-1);
        }
        else if(k == 0){
            Console.WriteLine(String.Join("",output));
        }
        else{
            for(int i = 0, j = n - 1; k > 0 && i < j; i++, j--){
                if(str[i] == str[j]){
                    if(str[i] != '9' && k > 1){
                        output[i] = '9';
                        output[j] = '9';
                        k -= 2;
                    }
                }
                else if(output[i] != '9'){
                        output[i] = '9';
                        output[j] = '9';
                        k -= 1;
                }
            }
            
            if(k > 0 && n % 2 > 0 && str[n/2] != '9'){
                output[n/2] = '9';
                k--;
            }
            Console.WriteLine(String.Join("",output));
        }
    }
}
