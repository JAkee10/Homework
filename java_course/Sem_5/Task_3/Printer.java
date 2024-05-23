package Sem_5.Task_3;


// TODO - НИЧЕГО НЕ ПОНЯТНО!    Погрузиться в деревья!


/*
 * Task 3
Необходимо разработать программу для сортировки массива целых чисел с использованием сортировки кучей (Heap Sort). 
Программа должна работать следующим образом:

Принимать на вход массив целых чисел для сортировки. Если массив не предоставлен, программа использует массив по умолчанию.

Сначала выводить исходный массив на экран.

Затем применять сортировку кучей (Heap Sort) для сортировки элементов массива в порядке возрастания.

Выводить отсортированный массив на экран.

Ваше решение должно содержать два основных метода: 
buildTree, который строит сортирующее дерево на основе массива, и heapSort, который выполняет собственно сортировку кучей.

Программа должна быть способной сортировать массив, даже если он состоит из отрицательных чисел и имеет дубликаты.
 */

import java.util.Arrays;

class HeapSort {
    public static void buildTree(int[] tree, int sortLength) {
        // Начинаем с последнего внутреннего узла и просеиваем вниз
        for (int i = sortLength / 2 - 1; i >= 0; i--) {
            int largest = i; // Предполагаем, что текущий узел - самый большой
            int left = 2 * i + 1; // Левый потомок
            int right = 2 * i + 2; // Правый потомок

            // Сравниваем текущий узел с левым потомком
            if (left < sortLength && tree[left] > tree[largest]) {
                largest = left;
            }

            // Сравниваем текущий узел с правым потомком
            if (right < sortLength && tree[right] > tree[largest]) {
                largest = right;
            }

            // Если самый большой элемент не является текущим узлом, меняем их местами
            if (largest != i) {
                int temp = tree[i];
                tree[i] = tree[largest];
                tree[largest] = temp;
            }
        }
    }

    public static void heapSort(int[] sortArray, int sortLength) {
        // Сначала строим сортирующее дерево
        buildTree(sortArray, sortLength);
        
        // Постепенно извлекаем максимальные элементы из кучи и перестраиваем ее
        for (int i = sortLength - 1; i > 0; i--) {
            // Меняем местами корень (максимальный элемент) с последним элементом в куче
            int temp = sortArray[0];
            sortArray[0] = sortArray[i];
            sortArray[i] = temp;
            // Перестраиваем кучу без последнего элемента (уже отсортированного)
            buildTree(sortArray, i);
        }
    }
}


// Не удаляйте и не меняйте метод Main!
public class Printer {
    public static void main(String[] args) {
        int[] initArray;

        if (args.length == 0) {
            initArray = new int[] { 17, 32, 1, 4, 25, 17, 0, 3, 10, 7, 64, 1 };
        } else {
            initArray = Arrays.stream(args[0].split(" ")).mapToInt(Integer::parseInt).toArray();
        }

        System.out.println("Initial array:");
        System.out.println(Arrays.toString(initArray));
        HeapSort.heapSort(initArray, initArray.length);
        System.out.println("Sorted array:");
        System.out.println(Arrays.toString(initArray));
    }
}
