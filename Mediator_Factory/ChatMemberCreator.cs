using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Factory
{
    abstract class ChatMemberCreator
    {
        // фабричный метод
        abstract public ChatMember Create(string name);
    }
}
