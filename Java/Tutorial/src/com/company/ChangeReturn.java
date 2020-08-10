package com.company;


public class ChangeReturn {
    public static int[] Surrender(double priceOld, double sumOld){
        int price = (int)(priceOld*100);
        int sum = (int)(sumOld*100);
        int [] answer = new int[]{0,0,0,0,0,0};
        if(sum<0 || price < 0){
          //  System.out.println("What????");
            answer[0] = -1;
            return answer;
        }
        if (sum < price ){
          //  System.out.println("It`s not enough");
            answer[0] = -1;

            return answer;
        }
        if(price == sum){
          //  System.out.println("You return is 0");
            return answer;
        }

        int surrender = sum - price;
       // System.out.println(surrender);
        double [] coin= new double[]{10,5,2,1,0.5,0.1};// 10, 5, 2, 1, 0.5, 0.1 == 1000, 500, 200, 100, 50, 10
        for(int i = 0;i<answer.length;i++){
            answer[i]=surrender/(int)(coin[i]*100);
            surrender%=(int)(coin[i]*100);
           // System.out.print(answer[i]+" ");
        }
      //  System.out.print("\n");
        return answer;
    }
}
