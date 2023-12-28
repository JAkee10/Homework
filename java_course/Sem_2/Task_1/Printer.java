package Sem_2.Task_1;
/*
 * Сформируйте часть WHERE этого запроса, используя StringBuilder. Данные (параметры) для фильтрации приведены в виде json-строки в примере ниже. Если значение null, то параметр не должен попадать в запрос.

Напишите свой код в методе answer класса Answer. Метод answer принимает на вход два параметра:

String QUERY - начало SQL-запроса String PARAMS - JSON с параметрами

Результат:
select * from students where name='Ivanov' and country='Russia' and city='Moscow'
 */
class Answer {  
    public static StringBuilder answer(String QUERY, String PARAMS){
        // Напишите свое решение ниже
        StringBuilder sb = new StringBuilder(QUERY);
        PARAMS = PARAMS.trim();
        String[] params = PARAMS.substring(1, PARAMS.length()-1).split(", ");
        for (String string : params) {
            if (!string.split(":")[1].equals("\"null\"")) {
              sb.append(string.split(":")[0].substring(1, string.split(":")[0].length() - 1)).append("='").append(string.split(":")[1].substring(1, string.split(":")[1].length() - 1)).append("' and ");
            }
        }
        sb.delete(sb.length() - 5, sb.length());
        return sb;
    }
}


// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class Printer{ 
	public static void main(String[] args) { 
      String QUERY = "";
      String PARAMS = "";
      
      if (args.length == 0) {
        // При отправке кода на Выполнение, вы можете варьировать эти параметры
        QUERY = "select * from students where ";
	    PARAMS = "{\"name\":\"Ivanov\", \"country\":\"Russia\", \"city\":\"Moscow\", \"age\":\"null\"} ";
      }
      else{
        QUERY = args[0];
        PARAMS = args[1];
      }     
      
      Answer ans = new Answer();      
      System.out.println(ans.answer(QUERY, PARAMS));
	}
}