# Угадай число

Этот проект представляет собой консольное приложение на C#, которое генерирует случайное число в заданном диапазоне и предлагает пользователю угадать его.

## Описание

Программа работает в режиме бесконечного цикла, предлагая пользователю ввести диапазон чисел и угадывать случайное число, сгенерированное в этом диапазоне. После каждой попытки программа указывает, больше или меньше загаданное число по сравнению с введённым числом. Если число угадано правильно, программа сообщает количество попыток и предлагает сыграть ещё раз.

## Как использовать

1. Склонируйте репозиторий или скопируйте исходный код.
2. Откройте проект в вашей среде разработки (например, Visual Studio).
3. Запустите проект.

### Пример использования

```
От какого числа мне загадать: 1
До какого числа мне загадать: 100
Я загадал число, попробуйте его отгадать.
Введите число: 50
Неверный ответ. Число больше.
Введите число: 75
Неверный ответ. Число меньше.
Введите число: 60
Неверный ответ. Число меньше.
Введите число: 57
Вы угадали! Число 57.
Число попыток 4.

Хотите сыграть ещё раз? (yes/y)
```