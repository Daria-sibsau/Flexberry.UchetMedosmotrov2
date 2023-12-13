import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  дата: DS.attr('date', { defaultValue() { return new Date(); } }),
  номерДок: DS.attr('number'),
  контингентСотр: DS.hasMany('i-i-s-uchet-medosmotrov2-контингент-сотр', { inverse: 'списокНаМедосм', async: false })
});

export let ValidationRules = {
  дата: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov2-список-на-медосм.validations.дата.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
    ],
  },
  номерДок: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov2-список-на-медосм.validations.номерДок.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  контингентСотр: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov2-список-на-медосм.validations.контингентСотр.__caption__',
    validators: [
      validator('ds-error'),
      validator('has-many'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('СписокНаМедосмE', 'i-i-s-uchet-medosmotrov2-список-на-медосм', {
    номерДок: attr('Номер документа', { index: 0 }),
    дата: attr('Дата', { index: 1 }),
    контингентСотр: hasMany('i-i-s-uchet-medosmotrov2-контингент-сотр', 'Контингент сотрудников', {
      мужчины: attr('Мужчины', { index: 0 }),
      женщины: attr('Женщины', { index: 1 }),
      до21Года: attr('До 21 года', { index: 2 }),
      всего: attr('Всего', { index: 3 }),
      классВредФакт: belongsTo('i-i-s-uchet-medosmotrov2-класс-вред-факт', 'Класс вред факт', {
        наименование: attr('Фактор производства', { index: 5, hidden: true })
      }, { index: 4, displayMemberPath: 'наименование' }),
      приказМЗР: belongsTo('i-i-s-uchet-medosmotrov2-приказ-м-з-р', 'Приказ МЗР', {
        номерПункта: attr('Номер пункта', { index: 7, hidden: true })
      }, { index: 6, displayMemberPath: 'номерПункта' }),
      периодичность: attr('Периодичность', { index: 8 })
    })
  });

  modelClass.defineProjection('СписокНаМедосмL', 'i-i-s-uchet-medosmotrov2-список-на-медосм', {
    номерДок: attr('Номер док', { index: 0 }),
    дата: attr('Дата', { index: 1 })
  });
};
