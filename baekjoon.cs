using System;
using System.Diagnostics;

class Program {
  public static bool check_prime(int a){
    int A=a;
    int cn=3;
    while(A>=cn){
      if(A==cn){
        return true;
      }
      else if(A%cn==0){
        return false;
      }
      else{
      cn+=2;
      }
    }
    return false;
  }

  public static void make_prime(int a, int n){
    int[] pn={1,3,7,9};
    int num;
    if(n==1){
      Console.WriteLine("{0}",a);
    }
    for(int i=0; i<pn.Length; i++){
      num=a*10+pn[i];
      if(a+pn[i]%3!=0 && (a-2*pn[i])%7!=0){
        if(check_prime(num)){
          make_prime(num,n-1);
        }
      }
    }
  }
  
  public static void Main (string[] args) {
    Stopwatch stopwatch = new Stopwatch(); //객체 선언
    stopwatch.Start(); // 시간측정 시작
    int N = Convert.ToInt32(Console.ReadLine());
    int[] fn={2,3,5,7};
    for(int i=0; i<fn.Length; i++){
      make_prime(fn[i],N);
    }
    stopwatch.Stop(); //시간측정 끝
 
    System.Console.WriteLine("time : " + stopwatch.ElapsedMilliseconds + "ms");
  }
}