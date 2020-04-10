using MediatR;

namespace CoreLayer.CoreCommand
{
    public interface ICommand : IRequest
    {
    }

    public interface ICommand<out TResult> : IRequest<TResult>
    {
    }
}
