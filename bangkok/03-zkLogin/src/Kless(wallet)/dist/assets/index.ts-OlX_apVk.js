import{W as o}from"./WindowMessageStream-BhNzlv8e.js";import{t as i,m as c,F as m}from"./Message-BmumhDZC.js";import{l as u}from"./lastValueFrom-DQrRdIu3.js";import"./mergeMap-CRZcgDlV.js";import.meta&&import.meta.url&&new URL(import.meta.url).pathname.substring(0,new URL(import.meta.url).pathname.lastIndexOf("/")+1);function l(s,{name:e,version:t}){const n=window;n.injectedWeb3=n.injectedWeb3||{},n.injectedWeb3[e]={enable:r=>s(r),version:t}}function a(s,e){return u(s.pipe(i(1),c(t=>{if(t&&m(t))throw new Error(t.message);return e(t)})))}class g{constructor(e){this.messagesStream=e}get(e){return a(this.messagesStream.sendRequest({type:"get-account"}),t=>t.accounts)}subscribe(e){const t=this.messagesStream.sendRequest({type:"get-account"}).subscribe(n=>{e(n.accounts)});return()=>{t.unsubscribe()}}}class d{get(){return[]}provide(e){return!1}}let p=0;class w{constructor(e){this.messagesStream=e}async signPayload(e){console.log("signPayload",e);const t=++p;return a(this.messagesStream.sendRequest({type:"sign-transaction-request",transaction:e}),n=>{console.log("signPayload response",n);const r=new Error("signPayload response");throw r.id=t,r.message="signPayload response",r.result=n.result,r})}async signRaw(){throw new Error("Unsupported signRaw")}}class h{constructor(e){this.accounts=new g(e),this.metadata=new d,this.signer=new w(e)}}const y=new o("kless_in-page","kless_content-script");function b(s){l(()=>Promise.resolve(new h(s)),{name:"kless-wallet",version:"0.1.0"})}b(y);