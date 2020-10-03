﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using BackOfficeFoodService.RefitInternalGenerated;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace BackOfficeFoodService.RefitInternalGenerated
{
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning disable CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
namespace BackOfficeFoodService.Servico
{
    using global::BackOfficeFoodService.Models;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Refit;
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedICardapioServico : ICardapioServico
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedICardapioServico(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<ActionResultado> ICardapioServico.Post(CardapioModel cardapioModel)
        {
            var arguments = new object[] { cardapioModel };
            var func = requestBuilder.BuildRestResultFuncForMethod("Post", new Type[] { typeof(CardapioModel) });
            return (Task<ActionResultado>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<CardapioModel>> ICardapioServico.GetListCardapioPorCliente(string cliente)
        {
            var arguments = new object[] { cliente };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetListCardapioPorCliente", new Type[] { typeof(string) });
            return (Task<List<CardapioModel>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<ActionResultado> ICardapioServico.PostListCardapio(MenuModel listModel)
        {
            var arguments = new object[] { listModel };
            var func = requestBuilder.BuildRestResultFuncForMethod("PostListCardapio", new Type[] { typeof(MenuModel) });
            return (Task<ActionResultado>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<MenuModel>> ICardapioServico.GetListMenuCardapioPorId(int IdCardapio)
        {
            var arguments = new object[] { IdCardapio };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetListMenuCardapioPorId", new Type[] { typeof(int) });
            return (Task<List<MenuModel>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<ActionResultado> ICardapioServico.DeleleteListaMenu(string codMenuSeq)
        {
            var arguments = new object[] { codMenuSeq };
            var func = requestBuilder.BuildRestResultFuncForMethod("DeleleteListaMenu", new Type[] { typeof(string) });
            return (Task<ActionResultado>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<ActionResultado> ICardapioServico.UpdateListaMenu(MenuModel listModel)
        {
            var arguments = new object[] { listModel };
            var func = requestBuilder.BuildRestResultFuncForMethod("UpdateListaMenu", new Type[] { typeof(MenuModel) });
            return (Task<ActionResultado>)func(Client, arguments);
        }
    }
}

namespace BackOfficeFoodService.Servico
{
    using global::BackOfficeFoodService.Models;
    using global::Refit;
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedIClienteServico : IClienteServico
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIClienteServico(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<ActionResultado> IClienteServico.Post(ClienteModel clienteModel)
        {
            var arguments = new object[] { clienteModel };
            var func = requestBuilder.BuildRestResultFuncForMethod("Post", new Type[] { typeof(ClienteModel) });
            return (Task<ActionResultado>)func(Client, arguments);
        }
    }
}

namespace BackOfficeFoodService.Servico
{
    using global::BackOfficeFoodService.Models;
    using global::Refit;
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedILoginAPI : ILoginAPI
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedILoginAPI(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<Token> ILoginAPI.PostCredentials(LoginModel user)
        {
            var arguments = new object[] { user };
            var func = requestBuilder.BuildRestResultFuncForMethod("PostCredentials", new Type[] { typeof(LoginModel) });
            return (Task<Token>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Token> ILoginAPI.RegisterUser(LoginModel user)
        {
            var arguments = new object[] { user };
            var func = requestBuilder.BuildRestResultFuncForMethod("RegisterUser", new Type[] { typeof(LoginModel) });
            return (Task<Token>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Usuario> ILoginAPI.Get()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] {  });
            return (Task<Usuario>)func(Client, arguments);
        }
    }
}

namespace BackOfficeFoodService.Servico
{
    using global::BackOfficeFoodService.Models;
    using global::Refit;
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedIProdutoServico : IProdutoServico
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIProdutoServico(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<ActionResultado> IProdutoServico.Post(ProdutoModel produtoModel)
        {
            var arguments = new object[] { produtoModel };
            var func = requestBuilder.BuildRestResultFuncForMethod("Post", new Type[] { typeof(ProdutoModel) });
            return (Task<ActionResultado>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<ProdutoModel>> IProdutoServico.GetListProdutoPorCliente(string cliente)
        {
            var arguments = new object[] { cliente };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetListProdutoPorCliente", new Type[] { typeof(string) });
            return (Task<List<ProdutoModel>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<ProdutoModel>> IProdutoServico.GetListProdutoPorListProduto(List<int> listProduto)
        {
            var arguments = new object[] { listProduto };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetListProdutoPorListProduto", new Type[] { typeof(List<int>) });
            return (Task<List<ProdutoModel>>)func(Client, arguments);
        }
    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning restore CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
