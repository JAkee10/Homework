package Sem_4.Task_3;
/*
 * В обычный калькулятор без логирования добавьте возможность отменить последнюю операцию.

Отмена последней операции должна быть реализована следующим образом: если передан оператор '<' калькулятор должен вывести результат предпоследней операции.

примеры:
calculate('+', 3, 7)
calculate('+', 4, 7)
calculate('<', 0, 0)

// 10.0
// 11.0
// 10.0

calculate('*', 3, 2)
calculate('-', 7, 4)
calculate('<', 0, 0)

// 6.0
// 3.0
// 6.0
 */
import java.util.ArrayDeque;
import java.util.Deque;

class Calculator {
    Deque<Double> dequeue = new ArrayDeque<>();

    public Double calculate(char op, int a, int b) {
        // Напишите свое решение ниже
        Double a2 = Double.valueOf(a);
        Double b2 = Double.valueOf(b);
        switch (op) {
            case '+':
                dequeue.push(Double.valueOf(a2 + b2));
                return a2 + b2;
            case '-':
                dequeue.push(Double.valueOf(a2 - b2));
                return a2 - b2;
            case '/':
                dequeue.push(Double.valueOf(a2 / b2));
                return a2 / b2;
            case '%':
                dequeue.push(Double.valueOf(a2 % b2));
                return a2 % b2;
            case '*':
                dequeue.push(Double.valueOf(a2 * b2));
                return a2 * b2;
            case '<':
                dequeue.pop();
                return dequeue.peek();
            default:
                return 0.0;
        }
    }
}

// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class Printer {
    public static void main(String[] args) {
        int a, b, c, d;
        char op, op2, undo;

        if (args.length == 0) {
            // При отправке кода на Выполнение, вы можете варьировать эти параметры
            a = 3;
            op = '+';
            b = 7;
            c = 4;
            op2 = '+';
            d = 7;
            undo = '<';
        } else {
            a = Integer.parseInt(args[0]);
            op = args[1].charAt(0);
            b = Integer.parseInt(args[2]);
            c = Integer.parseInt(args[3]);
            op2 = args[4].charAt(0);
            d = Integer.parseInt(args[5]);
            undo = args[6].charAt(0);
        }

        Calculator calculator = new Calculator();
        double result = calculator.calculate(op, a, b);
        System.out.println(result);
        double result2 = calculator.calculate(op2, c, d);
        System.out.println(result2);
        double prevResult = calculator.calculate(undo, 0, 0);
        System.out.println(prevResult);
    }
}