# Questionary
Описание тестового задания находится в файле Test Task Description.pdf

Реализована общая архитектура, которая позволяет разделить работу по проекту в команде программистов.
Реализованы несколько команд (exit, help, new_profile, вопросы/ответы, save), которые могут быть использованы в качестве шаблонов и подходов для реализации остальных команд.

Точки расширения:
1. Команды: CommandTypeEnum / CommandHandlerDictionary / Questionary.Business.Commands
2. Экраны: ScreenTypeEnum / ScreenFactoryDictionary / Questionary.UI.Screens
3. Валидаторы: Questionary.Business.Validation
4. Печатные формы: Questionary.Business.PrintForms

Ключевые моменты:
1. Инфраструктура обработки действий пользователя реализована в классе Questionary.UI.Dispatcher
2. Каждый экран имеет список доступных команд из перечня CommandTypeEnum
3. Можно расширять функционал добавлением новых команд (в Questionary.Business.Commands) и новых экранов (в Questionary.UI.Screens)
4. В app.config можно хранить параметры приложения по бизнес логике
5. Все тексты на русском языке вынесены в класс Questionary.Resources.Text, что позволит в будущем легко добавить локализацию
