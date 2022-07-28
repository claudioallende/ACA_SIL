﻿using Domain.Models.Connections;

namespace Domain.Models.Compartidos
{
  public abstract class DomainStore
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainService"/> class.
    /// </summary>
    /// <param name="context">
    /// The context.
    /// </param>
    protected DomainStore(SQLDBContext context)
    {
      this.Context = context;
    }

    /// <summary>
    /// Obtiene the context.
    /// </summary>
    public SQLDBContext Context { get; private set; }
  }
}
