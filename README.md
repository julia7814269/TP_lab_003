# Приложение для просмотра данных о доле плохих дорог и температуре в городе
## Общее описание:
Приложение включает в себя три формы, при запуске на экран выводится главная с кнопками запуска форм с данными о доле плохих дорог и температуре за месяц. 
## Описание формы: температура в городе
Слева на форме расположена таблица с данными, которые считываются из файла формата excel по нажатию кнопки "Загрузить файл". C правой части находятся графики максимальной, средней и минимальной температуры, обозначенные разными цветами, а также график прогноза. Параметры для прогноза вводятся пользователем в numericUpDown, а затем выводится график прогноза температуры при нажатии на кнопку "Прогноз". Также есть кнопка "Закрыть" для закрытия формы.
## Описание формы: доля плохих дорог
В левом верхнем углу расположена кнопка "Открыть таблицу из файла", которая выводит данные в dataGridView снизу на форме. По центру находится поле для графика, регион для которого выбирается в comboBox. Кроме того сверху расположены поля для вывода информации о максимальном и минимальном уменьшениях долей, а также поля вывода значения прогноза. Пользователь может ввести значения для прогнозирования. После нажатия кнопки "Прогнозировать" выводится график прогноза, обозначенный пунктиром. 
