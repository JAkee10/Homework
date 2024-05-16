package Sem_3.Task_1;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;
import java.util.Collections;
import java.util.List;

public class Test {
    public static void main(String[] args) {
        int[] a = {5, 1, 6, 2, 3, 4};
        int[] sortedArray = mergeSort(a);
        System.out.println(Arrays.toString(sortedArray));
    }

    static int[] mergeSort(int[] a) {
        int half = a.length/2;
        int[] leftHalf;
        int[] rightHalf;
        if (a.length <= 1) {
            return a;
        }
        else {
            leftHalf = mergeSort(Arrays.copyOfRange(a, 0, half));
            rightHalf = mergeSort(Arrays.copyOfRange(a, half, a.length));
        }
        return merge(leftHalf, rightHalf);
        // System.out.println(Arrays.toString(a1) + Arrays.toString(a2));
    }

    static int[] merge(int[] leftHalf, int[] rightHalf) {
        int[] result = new int[leftHalf.length + rightHalf.length];
        int indexLeft = 0;
        int indexRight = 0;
        int indexResult = 0;
        while (indexLeft < leftHalf.length && indexRight < rightHalf.length) {
            if (leftHalf[indexLeft] <= rightHalf[indexRight]) {
                result[indexResult++] = leftHalf[indexLeft++];
            } else {
                result[indexResult++] = rightHalf[indexRight++];
            }
        }
        while (indexLeft < leftHalf.length) {
            result[indexResult++] = leftHalf[indexLeft++];
        }

        while (indexRight < rightHalf.length) {
            result[indexResult++] = rightHalf[indexRight++];
        }
        System.out.println(Arrays.toString(leftHalf) + Arrays.toString(rightHalf));
        return result;
    }
}
