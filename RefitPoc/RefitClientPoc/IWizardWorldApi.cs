﻿using Refit;
using RefitClientPoc.ElixirsData;

namespace RefitClientPoc;

public interface IWizardWorldApi {
    [Get("/Elixirs/{id}")]
    Task<Elixir> GetElixir(Guid id);
}