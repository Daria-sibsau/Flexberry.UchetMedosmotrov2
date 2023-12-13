import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.uchet-medosmotrov2.caption'),
          title: i18n.t('forms.application.sitemap.uchet-medosmotrov2.title'),
          children: [{
            link: 'i-i-s-uchet-medosmotrov2-сотрудники-l',
            caption: i18n.t('forms.application.sitemap.uchet-medosmotrov2.i-i-s-uchet-medosmotrov2-сотрудники-l.caption'),
            title: i18n.t('forms.application.sitemap.uchet-medosmotrov2.i-i-s-uchet-medosmotrov2-сотрудники-l.title'),
            icon: 'folder open',
            children: null
          }, {
            link: 'i-i-s-uchet-medosmotrov2-подразделения-l',
            caption: i18n.t('forms.application.sitemap.uchet-medosmotrov2.i-i-s-uchet-medosmotrov2-подразделения-l.caption'),
            title: i18n.t('forms.application.sitemap.uchet-medosmotrov2.i-i-s-uchet-medosmotrov2-подразделения-l.title'),
            icon: 'table',
            children: null
          }, {
            link: 'i-i-s-uchet-medosmotrov2-приказ-м-з-р-l',
            caption: i18n.t('forms.application.sitemap.uchet-medosmotrov2.i-i-s-uchet-medosmotrov2-приказ-м-з-р-l.caption'),
            title: i18n.t('forms.application.sitemap.uchet-medosmotrov2.i-i-s-uchet-medosmotrov2-приказ-м-з-р-l.title'),
            children: null
          }, {
            link: 'i-i-s-uchet-medosmotrov2-инд-напр-медосм-l',
            caption: i18n.t('forms.application.sitemap.uchet-medosmotrov2.i-i-s-uchet-medosmotrov2-инд-напр-медосм-l.caption'),
            title: i18n.t('forms.application.sitemap.uchet-medosmotrov2.i-i-s-uchet-medosmotrov2-инд-напр-медосм-l.title'),
            icon: 'archive',
            children: null
          }, {
            link: 'i-i-s-uchet-medosmotrov2-список-на-медосм-l',
            caption: i18n.t('forms.application.sitemap.uchet-medosmotrov2.i-i-s-uchet-medosmotrov2-список-на-медосм-l.caption'),
            title: i18n.t('forms.application.sitemap.uchet-medosmotrov2.i-i-s-uchet-medosmotrov2-список-на-медосм-l.title'),
            icon: 'tasks',
            children: null
          }, {
            link: 'i-i-s-uchet-medosmotrov2-организация-l',
            caption: i18n.t('forms.application.sitemap.uchet-medosmotrov2.i-i-s-uchet-medosmotrov2-организация-l.caption'),
            title: i18n.t('forms.application.sitemap.uchet-medosmotrov2.i-i-s-uchet-medosmotrov2-организация-l.title'),
            icon: 'chart line',
            children: null
          }, {
            link: 'i-i-s-uchet-medosmotrov2-класс-вред-факт-l',
            caption: i18n.t('forms.application.sitemap.uchet-medosmotrov2.i-i-s-uchet-medosmotrov2-класс-вред-факт-l.caption'),
            title: i18n.t('forms.application.sitemap.uchet-medosmotrov2.i-i-s-uchet-medosmotrov2-класс-вред-факт-l.title'),
            icon: 'tags',
            children: null
          }, {
            link: 'i-i-s-uchet-medosmotrov2-должности-l',
            caption: i18n.t('forms.application.sitemap.uchet-medosmotrov2.i-i-s-uchet-medosmotrov2-должности-l.caption'),
            title: i18n.t('forms.application.sitemap.uchet-medosmotrov2.i-i-s-uchet-medosmotrov2-должности-l.title'),
            icon: 'suitcase',
            children: null
          }]
        }
      ]
    };
  }),
})