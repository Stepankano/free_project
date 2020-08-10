package com.company;

import java.util.Arrays;

public class ChangeReturnTest {
    public static void Test() {

       System.out.println(Arrays.equals( ChangeReturn.Surrender(500, 200),(new int[]{-1,0,0,0,0,0})));
        System.out.println(Arrays.equals( ChangeReturn.Surrender(100, -18),(new int[]{-1,0,0,0,0,0})));
        System.out.println(Arrays.equals( ChangeReturn.Surrender(900,900),(new int[]{0,0,0,0,0,0})));
        System.out.println(Arrays.equals( ChangeReturn.Surrender(-100, 0),(new int[]{-1,0,0,0,0,0})));
        System.out.println(Arrays.equals( ChangeReturn.Surrender(200,500),(new int[]{30,0,0,0,0,0})));
        System.out.println(Arrays.equals( ChangeReturn.Surrender(30.5,46.5),(new int[]{1,1,0,1,0,0})));
    }
}
