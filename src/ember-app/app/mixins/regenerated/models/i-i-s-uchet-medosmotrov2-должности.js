import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  наименование: DS.attr('string'),
  подразделения: DS.belongsTo('i-i-s-uchet-medosmotrov2-подразделения', { inverse: null, async: false })
});

export let ValidationRules = {
  наименование: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov2-должности.validations.наименование.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  подразделения: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov2-должности.validations.подразделения.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ДолжностиE', 'i-i-s-uchet-medosmotrov2-должности', {
    наименование: attr('Наименование', { index: 0 }),
    подразделения: belongsTo('i-i-s-uchet-medosmotrov2-подразделения', 'Подразделения', {
      наименование: attr('Подразделение', { index: 2, hidden: true })
    }, { index: 1, displayMemberPath: 'наименование' })
  });

  modelClass.defineProjection('ДолжностиL', 'i-i-s-uchet-medosmotrov2-должности', {
    наименование: attr('Наименование', { index: 0 }),
    подразделения: belongsTo('i-i-s-uchet-medosmotrov2-подразделения', 'Наименование', {
      наименование: attr('Наименование', { index: 1 })
    }, { index: -1, hidden: true })
  });
};
