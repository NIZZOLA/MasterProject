﻿using BackOffice.Domain.Interfaces.Repository;
using BackOffice.Infra.Sql.Data;

namespace BackOffice.Infra.Sql.Repository; 
public class PagamentoRepository: BaseRepository, IPagamentoRepository 
{
	public PagamentoRepository(BackOfficeContext context) : base(context)
    {

    }
}
