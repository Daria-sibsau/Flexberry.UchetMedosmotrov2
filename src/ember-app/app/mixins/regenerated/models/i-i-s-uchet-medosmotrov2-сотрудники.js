import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  iDСотрудника: DS.attr('number'),
  датаРождения: DS.attr('date'),
  номерПаспорта: DS.attr('number'),
  пол: DS.attr('i-i-s-uchet-medosmotrov2-пол-сотрудника'),
  серияПаспорта: DS.attr('number'),
  телефон: DS.attr('number'),
  фИО: DS.attr('string'),
  должности: DS.belongsTo('i-i-s-uchet-medosmotrov2-должности', { inverse: null, async: false })
});

export let ValidationRules = {
  iDСотрудника: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov2-сотрудники.validations.iDСотрудника.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  датаРождения: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov2-сотрудники.validations.датаРождения.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
    ],
  },
  номерПаспорта: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov2-сотрудники.validations.номерПаспорта.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  пол: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov2-сотрудники.validations.пол.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  серияПаспорта: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov2-сотрудники.validations.серияПаспорта.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  телефон: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov2-сотрудники.validations.телефон.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  фИО: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov2-сотрудники.validations.фИО.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  должности: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov2-сотрудники.validations.должности.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('СотрудникиE', 'i-i-s-uchet-medosmotrov2-сотрудники', {
    фИО: attr('ФИО', { index: 0 }),
    пол: attr('Пол', { index: 1 }),
    датаРождения: attr('Дата рождения', { index: 2 }),
    серияПаспорта: attr('Серия паспорта', { index: 3 }),
    номерПаспорта: attr('Номер паспорта', { index: 4 }),
    телефон: attr('Телефон', { index: 5 }),
    iDСотрудника: attr('ID сотрудника', { index: 6 })
  });

  modelClass.defineProjection('СотрудникиL', 'i-i-s-uchet-medosmotrov2-сотрудники', {
    фИО: attr('ФИО', { index: 0 }),
    пол: attr('Пол', { index: 1 }),
    датаРождения: attr('Дата рождения', { index: 2 }),
    серияПаспорта: attr('Серия паспорта', { index: 3 }),
    номерПаспорта: attr('Номер паспорта', { index: 4 }),
    телефон: attr('Телефон', { index: 5 }),
    iDСотрудника: attr('I d сотрудника', { index: 6 }),
    должности: belongsTo('i-i-s-uchet-medosmotrov2-должности', 'Наименование', {
      наименование: attr('Наименование', { index: 7 })
    }, { index: -1, hidden: true })
  });
};
