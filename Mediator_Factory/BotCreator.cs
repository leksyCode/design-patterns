using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Factory
{
    class BotCreator : ChatMemberCreator
    {
        public override ChatMember Create(string name)
        {
            return new Bot(name);
        }
    }
}
