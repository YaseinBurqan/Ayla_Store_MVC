import{a as s,b as m,c as e,d as i}from"../../../_chunks/chunk-65EVPBFJ.js";import{a as o,b as c,c as n,e as d,f as l}from"../../../_chunks/chunk-RK3EK3FG.js";var u=c(l(),1);var a=c(d(),1);var r=class extends a.EntityDialog{constructor(){super(...arguments);this.form=new m(this.idPrefix)}getFormKey(){return m.formKey}getIdProperty(){return e.idProperty}getLocalTextPrefix(){return e.localTextPrefix}getNameProperty(){return e.nameProperty}getService(){return i.baseUrl}};o(r,"LanguageDialog"),r=n([a.Decorators.registerClass("AdminPanal.Administration.LanguageDialog")],r);var p=c(d(),1);var t=class extends p.EntityGrid{useAsync(){return!0}getColumnsKey(){return s.columnsKey}getDialogType(){return r}getIdProperty(){return e.idProperty}getLocalTextPrefix(){return e.localTextPrefix}getService(){return i.baseUrl}afterInit(){super.afterInit()}getDefaultSortBy(){return[e.Fields.LanguageName]}};o(t,"LanguageGrid"),t=n([p.Decorators.registerClass("AdminPanal.Administration.LanguageGrid")],t);$(function(){(0,u.initFullHeightGridPage)(new t($("#GridDiv")).element)});
//# sourceMappingURL=LanguagePage.js.map
