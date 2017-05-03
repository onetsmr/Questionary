namespace Questionary.Domain.Enums
{
    public enum CommandTypeEnum
    {
        Unknown = 0,
        GoToMainScreen = 1,
        Answer = 3,

        new_profile,
        statistics,
        save,
        goto_question,
        goto_prev_question,
        restart_profile,
        find,
        delete,
        list,
        list_today,
        zip,
        help,
        exit
    }
}
