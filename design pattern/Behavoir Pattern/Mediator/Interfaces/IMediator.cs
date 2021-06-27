using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.Behavoir_Pattern.Mediator.Interfaces
{
    public interface IMediator
    {
        void send(IMessageCommand messageCommand);
    }
}
