namespace EraXp.Frontend.Utils;

public static class DataState
{
    public static DataState<T>.Data Data<T>(T item)
    {
        return new DataState<T>.Data(item);
    }

    public static DataState<T>.Loading Loading<T>()
    {
        return new DataState<T>.Loading();
    }

    public static DataState<T>.Error Error<T>(string message)
    {
        return new DataState<T>.Error(message);
    }
}

public interface DataState<T>
{
    public string? ErrorMessage { get; }
    public string? LoadingMessage { get; }
    public bool IsLoading { get; }
    public bool IsError { get; }
    public bool IsData { get; }

    public record Data(T Item) : DataState<T>
    {
        public string? ErrorMessage => null;
        public string? LoadingMessage => null;
        public bool IsLoading => false;
        public bool IsError => false;
        public bool IsData => true;
    }

    public record Loading : DataState<T>
    {
        public string? ErrorMessage => null;
        public string? LoadingMessage => "Loading, Please wait...";
        public bool IsLoading => true;
        public bool IsError => false;
        public bool IsData => false;
    }

    public record Error(string Message) : DataState<T>
    {
        public string? ErrorMessage => Message;
        public string? LoadingMessage => null;
        public bool IsLoading => false;
        public bool IsError => true;
        public bool IsData => false;
    }
}