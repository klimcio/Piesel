namespace PeselValidator.Tools;

public enum ResultType
{
    OK = 1,
    NotAStringOf11Digits = 2,
    InvalidChecksum = 3,
    InvalidDate = 4,
    UnknownError = 5
}
