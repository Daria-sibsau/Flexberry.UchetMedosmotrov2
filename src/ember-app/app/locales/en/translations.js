import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/en/translations';

import IISUchetMedosmotrov2ДолжностиLForm from './forms/i-i-s-uchet-medosmotrov2-должности-l';
import IISUchetMedosmotrov2ИндНапрМедосмLForm from './forms/i-i-s-uchet-medosmotrov2-инд-напр-медосм-l';
import IISUchetMedosmotrov2КлассВредФактLForm from './forms/i-i-s-uchet-medosmotrov2-класс-вред-факт-l';
import IISUchetMedosmotrov2ОрганизацияLForm from './forms/i-i-s-uchet-medosmotrov2-организация-l';
import IISUchetMedosmotrov2ПодразделенияLForm from './forms/i-i-s-uchet-medosmotrov2-подразделения-l';
import IISUchetMedosmotrov2ПриказМЗРLForm from './forms/i-i-s-uchet-medosmotrov2-приказ-м-з-р-l';
import IISUchetMedosmotrov2СотрудникиLForm from './forms/i-i-s-uchet-medosmotrov2-сотрудники-l';
import IISUchetMedosmotrov2СписокНаМедосмLForm from './forms/i-i-s-uchet-medosmotrov2-список-на-медосм-l';
import IISUchetMedosmotrov2ДолжностиEForm from './forms/i-i-s-uchet-medosmotrov2-должности-e';
import IISUchetMedosmotrov2ИндНапрМедосмEForm from './forms/i-i-s-uchet-medosmotrov2-инд-напр-медосм-e';
import IISUchetMedosmotrov2КлассВредФактEForm from './forms/i-i-s-uchet-medosmotrov2-класс-вред-факт-e';
import IISUchetMedosmotrov2ОрганизацияEForm from './forms/i-i-s-uchet-medosmotrov2-организация-e';
import IISUchetMedosmotrov2ПодразделенияEForm from './forms/i-i-s-uchet-medosmotrov2-подразделения-e';
import IISUchetMedosmotrov2ПриказМЗРEForm from './forms/i-i-s-uchet-medosmotrov2-приказ-м-з-р-e';
import IISUchetMedosmotrov2СотрудникиEForm from './forms/i-i-s-uchet-medosmotrov2-сотрудники-e';
import IISUchetMedosmotrov2СписокНаМедосмEForm from './forms/i-i-s-uchet-medosmotrov2-список-на-медосм-e';
import IISUchetMedosmotrov2ВреднФактПроизModel from './models/i-i-s-uchet-medosmotrov2-вредн-факт-произ';
import IISUchetMedosmotrov2ДолжностиModel from './models/i-i-s-uchet-medosmotrov2-должности';
import IISUchetMedosmotrov2ИндНапрМедосмModel from './models/i-i-s-uchet-medosmotrov2-инд-напр-медосм';
import IISUchetMedosmotrov2КлассВредФактModel from './models/i-i-s-uchet-medosmotrov2-класс-вред-факт';
import IISUchetMedosmotrov2КонтингентСотрModel from './models/i-i-s-uchet-medosmotrov2-контингент-сотр';
import IISUchetMedosmotrov2ОрганизацияModel from './models/i-i-s-uchet-medosmotrov2-организация';
import IISUchetMedosmotrov2ПодразделенияModel from './models/i-i-s-uchet-medosmotrov2-подразделения';
import IISUchetMedosmotrov2ПриказМЗРModel from './models/i-i-s-uchet-medosmotrov2-приказ-м-з-р';
import IISUchetMedosmotrov2СотрудникиModel from './models/i-i-s-uchet-medosmotrov2-сотрудники';
import IISUchetMedosmotrov2СписокНаМедосмModel from './models/i-i-s-uchet-medosmotrov2-список-на-медосм';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-uchet-medosmotrov2-вредн-факт-произ': IISUchetMedosmotrov2ВреднФактПроизModel,
    'i-i-s-uchet-medosmotrov2-должности': IISUchetMedosmotrov2ДолжностиModel,
    'i-i-s-uchet-medosmotrov2-инд-напр-медосм': IISUchetMedosmotrov2ИндНапрМедосмModel,
    'i-i-s-uchet-medosmotrov2-класс-вред-факт': IISUchetMedosmotrov2КлассВредФактModel,
    'i-i-s-uchet-medosmotrov2-контингент-сотр': IISUchetMedosmotrov2КонтингентСотрModel,
    'i-i-s-uchet-medosmotrov2-организация': IISUchetMedosmotrov2ОрганизацияModel,
    'i-i-s-uchet-medosmotrov2-подразделения': IISUchetMedosmotrov2ПодразделенияModel,
    'i-i-s-uchet-medosmotrov2-приказ-м-з-р': IISUchetMedosmotrov2ПриказМЗРModel,
    'i-i-s-uchet-medosmotrov2-сотрудники': IISUchetMedosmotrov2СотрудникиModel,
    'i-i-s-uchet-medosmotrov2-список-на-медосм': IISUchetMedosmotrov2СписокНаМедосмModel
  },

  'application-name': 'Uchet medosmotrov2',

  forms: {
    loading: {
      'spinner-caption': 'Loading stuff, please wait for a moment...'
    },
    index: {
      greeting: 'Welcome to ember-flexberry test stand!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Menu'
          },
          'user-settings-service-checkbox': {
            caption: 'Use service to save user settings'
          },
          'show-menu': {
            caption: 'Show menu'
          },
          'hide-menu': {
            caption: 'Hide menu'
          },
          'language-dropdown': {
            caption: 'Application language',
            placeholder: 'Choose language'
          }
        },
        login: {
          caption: 'Login'
        },
        logout: {
          caption: 'Logout'
        }
      },

      footer: {
        'application-name': 'Uchet medosmotrov2',
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'Uchet medosmotrov2',
          title: 'Uchet medosmotrov2'
        },
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        },
        index: {
          caption: 'Home',
          title: ''
        },
        'uchet-medosmotrov2': {
          caption: 'UchetMedosmotrov2',
          title: 'UchetMedosmotrov2',
          'i-i-s-uchet-medosmotrov2-сотрудники-l': {
            caption: 'Сотрудники',
            title: ''
          },
          'i-i-s-uchet-medosmotrov2-подразделения-l': {
            caption: 'Подразделения',
            title: ''
          },
          'i-i-s-uchet-medosmotrov2-приказ-м-з-р-l': {
            caption: 'Приказ МЗР',
            title: ''
          },
          'i-i-s-uchet-medosmotrov2-инд-напр-медосм-l': {
            caption: 'Инд напр медосм',
            title: ''
          },
          'i-i-s-uchet-medosmotrov2-список-на-медосм-l': {
            caption: 'Список на медосм',
            title: ''
          },
          'i-i-s-uchet-medosmotrov2-организация-l': {
            caption: 'Организация',
            title: ''
          },
          'i-i-s-uchet-medosmotrov2-класс-вред-факт-l': {
            caption: 'Класс вред факт',
            title: ''
          },
          'i-i-s-uchet-medosmotrov2-должности-l': {
            caption: 'Должности',
            title: ''
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Save operation succeed',
      'save-success-message': 'Object saved',
      'save-error-message-caption': 'Save operation failed',
      'delete-success-message-caption': 'Delete operation succeed',
      'delete-success-message': 'Object deleted',
      'delete-error-message-caption': 'Delete operation failed'
    },
    'i-i-s-uchet-medosmotrov2-должности-l': IISUchetMedosmotrov2ДолжностиLForm,
    'i-i-s-uchet-medosmotrov2-инд-напр-медосм-l': IISUchetMedosmotrov2ИндНапрМедосмLForm,
    'i-i-s-uchet-medosmotrov2-класс-вред-факт-l': IISUchetMedosmotrov2КлассВредФактLForm,
    'i-i-s-uchet-medosmotrov2-организация-l': IISUchetMedosmotrov2ОрганизацияLForm,
    'i-i-s-uchet-medosmotrov2-подразделения-l': IISUchetMedosmotrov2ПодразделенияLForm,
    'i-i-s-uchet-medosmotrov2-приказ-м-з-р-l': IISUchetMedosmotrov2ПриказМЗРLForm,
    'i-i-s-uchet-medosmotrov2-сотрудники-l': IISUchetMedosmotrov2СотрудникиLForm,
    'i-i-s-uchet-medosmotrov2-список-на-медосм-l': IISUchetMedosmotrov2СписокНаМедосмLForm,
    'i-i-s-uchet-medosmotrov2-должности-e': IISUchetMedosmotrov2ДолжностиEForm,
    'i-i-s-uchet-medosmotrov2-инд-напр-медосм-e': IISUchetMedosmotrov2ИндНапрМедосмEForm,
    'i-i-s-uchet-medosmotrov2-класс-вред-факт-e': IISUchetMedosmotrov2КлассВредФактEForm,
    'i-i-s-uchet-medosmotrov2-организация-e': IISUchetMedosmotrov2ОрганизацияEForm,
    'i-i-s-uchet-medosmotrov2-подразделения-e': IISUchetMedosmotrov2ПодразделенияEForm,
    'i-i-s-uchet-medosmotrov2-приказ-м-з-р-e': IISUchetMedosmotrov2ПриказМЗРEForm,
    'i-i-s-uchet-medosmotrov2-сотрудники-e': IISUchetMedosmotrov2СотрудникиEForm,
    'i-i-s-uchet-medosmotrov2-список-на-медосм-e': IISUchetMedosmotrov2СписокНаМедосмEForm
  },

});

export default translations;
